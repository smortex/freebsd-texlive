# New ports collection makefile for:	texlive-epspdf
# Date created:		26/01/2009 16:10:44
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	epspdf
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Converter for PostScript, EPS and PDF.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
