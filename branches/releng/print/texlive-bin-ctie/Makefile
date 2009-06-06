# New ports collection makefile for:	texlive-bin-ctie
# Date created:		26/01/2009 16:03:40
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-ctie
PORTREVISION=	2
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@blogreen.org
COMMENT=	The bin-ctie package

RUN_DEPENDS=	${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-bin-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
