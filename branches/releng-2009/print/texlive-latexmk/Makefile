# New ports collection makefile for:	texlive-latexmk
# Date created:		13/03/2010 04:24:15
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	latexmk
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Fully automated LaTeX document generation routine.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
