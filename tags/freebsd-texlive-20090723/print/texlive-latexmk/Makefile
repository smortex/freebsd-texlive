# New ports collection makefile for:	texlive-latexmk
# Date created:		26/01/2009 16:03:46
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	latexmk
PORTREVISION=	11
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Fully automated LaTeX document generation routine.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
