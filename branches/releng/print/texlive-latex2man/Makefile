# New ports collection makefile for:	texlive-latex2man
# Date created:		13/03/2010 04:24:13
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	latex2man
PORTVERSION=	20120515
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Translate LaTeX-based manual pages into Unix man format.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
