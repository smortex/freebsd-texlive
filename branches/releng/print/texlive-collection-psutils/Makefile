# New ports collection makefile for:	texlive-collection-psutils
# Date created:		26/01/2009 16:11:20
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	collection-psutils
PORTREVISION=	3
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@blogreen.org
COMMENT=	Extra font utilities

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/dvips/dvipsconfig/README:${PORTSDIR}/print/texlive-dvipsconfig \
		${LOCALBASE}/share/texmf/dvips/getafm/getafm.ps:${PORTSDIR}/print/texlive-bin-getafm \
		${LOCALBASE}/share/texmf-dist/fonts/map/glyphlist/glyphlist.txt:${PORTSDIR}/print/texlive-glyphlist \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core \
		${LOCALBASE}/share/texmf/scripts/ps2eps/ps2eps.pl:${PORTSDIR}/print/texlive-bin-pstools \
		${LOCALBASE}/share/texmf/dvips/psutils/md68_0.ps:${PORTSDIR}/print/texlive-bin-psutils

LSE_LZMA=	yes
NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
