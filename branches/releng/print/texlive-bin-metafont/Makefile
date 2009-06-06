# New ports collection makefile for:	texlive-bin-metafont
# Date created:		26/01/2009 16:02:44
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-metafont
PORTREVISION=	3
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	The bin-metafont package

RUN_DEPENDS=	${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-bin-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
