# New ports collection makefile for:	texlive-pdftex
# Date created:		26/01/2009 16:02:51
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	pdftex
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	A TeX extension for direct creation of PDF.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-bin-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
