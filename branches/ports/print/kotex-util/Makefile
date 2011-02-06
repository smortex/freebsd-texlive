# New ports collection makefile for:	kotex-util
# Date created:		2011-02-06
# Whom:			Romain Tartiere <romain@FreeBSD.org>
#
# $FreeBSD$
#

PORTNAME=	kotex-util
PORTVERSION=	20100509
CATEGORIES=	print
MASTER_SITES=	http://ftp.ktug.or.kr/KTUG/ko.TeX/
DISTNAME=	${PORTNAME}-source-${PORTVERSION}

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Korean support for LaTeX (utilities)

WRKSRC=		${WRKDIR}

do-build:
	@( cd ${WRKSRC}/source/latex/kotex-util/ && ${MAKE} )

do-install:
	${INSTALL_PROGRAM} ${WRKSRC}/source/latex/kotex-util/hbibtex ${WRKSRC}/source/latex/kotex-util/hmakeindex ${PREFIX}/bin
	${INSTALL_SCRIPT} ${WRKSRC}/scripts/kotex-util/perl/* ${PREFIX}/bin

.include <bsd.port.pre.mk>
.include <bsd.port.post.mk>
